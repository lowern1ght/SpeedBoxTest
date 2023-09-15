import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react-swc'

//const BASE_URL = import.meta.env.WEB_SERVER_URL;

const proxySettings = {
  "/api": {
      target: `${"localhost"}`
    }
}

const portSettings = {
  strictPort: true,
  port: 3000
}

export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      ...proxySettings,
      "/swagger" : {
        target: "localhost"
      }
    },
    ...portSettings
  },
  preview: {
    proxy: {
      ...proxySettings
    },
    ...portSettings
  }
})