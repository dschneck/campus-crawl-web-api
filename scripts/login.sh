#!/bin/env bash
curl -X 'POST' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/users/login' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "email": "david.schneckster@hotmail.com",
  "password": "password"
}'
