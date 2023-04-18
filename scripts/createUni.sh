#!/bin/env bash
curl -X 'POST' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/universities' \
  -H "Authorization: Bearer $(gcloud auth print-identity-token)" \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "id": "string",
  "name": "string",
  "address": "string",
  "description": "string",
  "numberOfStudents": 0
}'
