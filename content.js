function extractImages() {
  return Array.from(document.images).map(img => img.src);
}

chrome.runtime.onMessage.addListener((message, sender, sendResponse) => {
  if (message.action === "fetch_images") {
    sendResponse({ images: extractImages() });
  }
});
