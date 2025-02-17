chrome.runtime.onMessage.addListener((message, sender, sendResponse) => {
  if (message.action === "download_image") {
    chrome.downloads.download({ url: message.imageUrl, filename: `image.jpg` });
    sendResponse({ status: "Download started" });
  }
});