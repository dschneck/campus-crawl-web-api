#!/bin/env bash
curl -X 'POST' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/users/register' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "Id": "",
  "Email": "michael@email.com",
  "password": "123",
  "FirstName": "Michael",
  "LastName": "Schneck",
  "UniversityId": "7ccc61f4-bb4c-45a6-be77-c9b3ea5e399b"
}'

echo ""
