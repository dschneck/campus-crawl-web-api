#!/bin/env bash
curl -X 'GET' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/universities' \
  -H "Authorization: Bearer $(gcloud auth print-identity-token)" \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json'

echo ""
