/* popup.css */
body {
  font-family: 'Inter', sans-serif;
  width: 480px;
  padding: 16px;
  background: #0f0f0f;
  color: #e0e0e0;
  border-radius: 12px;
  scrollbar-width: thin;
  scrollbar-color: #333 #1a1a1a;
}

.container {
  display: flex;
  flex-direction: column;
  gap: 16px;
}

h1 {
  font-size: 22px;
  margin: 0;
  font-weight: 600;
  color: #ffffff;
  letter-spacing: -0.5px;
}

.btn-group {
  display: flex;
  gap: 10px;
  width: 100%;
}

.btn {
  background: linear-gradient(135deg, #7c3aed 0%, #5b21b6 100%);
  color: white;
  border: none;
  padding: 12px 20px;
  margin: 0;
  cursor: pointer;
  width: 100%;
  border-radius: 8px;
  font-weight: 500;
  transition: all 0.2s ease;
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 8px;
}

.btn:hover {
  transform: translateY(-1px);
  box-shadow: 0 6px 12px rgba(92, 33, 182, 0.25);
}

.btn:active {
  transform: translateY(0);
  box-shadow: 0 2px 4px rgba(92, 33, 182, 0.25);
}

.image-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(140px, 1fr));
  gap: 16px;
  width: 100%;
  max-height: 420px;
  overflow-y: auto;
  padding: 4px;
}

.image-container {
  position: relative;
  background: #1a1a1a;
  border-radius: 12px;
  overflow: hidden;
  transition: transform 0.2s ease;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.image-container:hover {
  transform: translateY(-4px);
}

.image-preview {
  width: 100%;
  height: 140px;
  object-fit: contain;
  background: #242424;
  border-radius: 8px 8px 0 0;
}

.image-metadata {
  padding: 10px;
  background: rgba(0, 0, 0, 0.6);
  backdrop-filter: blur(4px);
  font-size: 11px;
  line-height: 1.4;
  color: #e0e0e0;
}

.download-btn {
  position: absolute;
  bottom: 8px;
  right: 8px;
  background: rgba(255, 255, 255, 0.9);
  color: #1a1a1a;
  padding: 6px 12px;
  border: none;
  cursor: pointer;
  border-radius: 6px;
  font-weight: 600;
  transition: all 0.2s ease;
  backdrop-filter: blur(4px);
}

.download-btn:hover {
  background: #ffffff;
  transform: scale(1.05);
}

.loading {
  display: none;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 24px;
  height: 24px;
  border: 3px solid rgba(255, 255, 255, 0.2);
  border-top-color: #ffffff;
  border-radius: 50%;
  animation: spin 1s linear infinite;
}

@keyframes spin {
  to { transform: rotate(360deg); }
}