FROM node:latest as build-stage
WORKDIR /app
COPY . .
RUN ls
RUN npm ci
RUN npm run build
RUN ls
FROM nginx:latest
COPY --from=build-stage /app/dist/front/browser/ /usr/share/nginx/html/
COPY ./docker/nginx/default.conf /etc/nginx/conf.d/default.conf
