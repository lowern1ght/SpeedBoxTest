FROM node:lts-alpine
ENV NODE_ENV=production
WORKDIR /usr/src/app
COPY ["package.json", "package-lock.json*", "npm-shrinkwrap.json*", "./"]
COPY . .
RUN npm install && npm i -g typescript vite && npm run build
EXPOSE 3000
CMD ["npm", "run", "preview"]