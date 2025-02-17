document.addEventListener("DOMContentLoaded", () => {
  const fetchButton = document.getElementById("fetch");
  const downloadButton = document.getElementById("downloadAll");
  const imageList = document.getElementById("imageList");

  fetchButton.addEventListener("click", () => {
    chrome.tabs.query({ active: true, currentWindow: true }, (tabs) => {
      chrome.scripting.executeScript({
        target: { tabId: tabs[0].id },
        func: () => Array.from(document.images).map(img => ({
          src: img.src,
          width: img.naturalWidth,
          height: img.naturalHeight,
          size: img.fileSize || 'Unknown'
        })),
      }, (results) => {
        const images = results[0].result;
        imageList.innerHTML = "";
        images.forEach(({ src, width, height, size }) => {
          let container = document.createElement("div");
          container.classList.add("image-container");
          let img = document.createElement("img");
          let metadata = document.createElement("div");
          let btn = document.createElement("button");

          img.src = src;
          img.classList.add("image-preview");
          metadata.innerHTML = `<span>JPG ${width}x${height} ${size}</span>`;
          metadata.classList.add("image-metadata");
          btn.innerText = "Download";
          btn.classList.add("download-btn");
          btn.addEventListener("click", () => {
            chrome.runtime.sendMessage({ action: "download_image", imageUrl: src });
          });
          
          container.appendChild(img);
          container.appendChild(metadata);
          container.appendChild(btn);
          imageList.appendChild(container);
        });
      });
    });
  });

  downloadButton.addEventListener("click", () => {
    const images = Array.from(document.querySelectorAll("#imageList img"))
                        .map(img => img.src);
    images.forEach(imgUrl => {
      chrome.runtime.sendMessage({ action: "download_image", imageUrl: imgUrl });
    });
  });
});
