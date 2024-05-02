FROM node:latest as build-stage
WORKDIR /app
COPY . .
RUN npm ci
RUN npm run build

FROM nginx:latest
COPY --from=build-stage /app/dist/front/browser/ /usr/share/nginx/html/
