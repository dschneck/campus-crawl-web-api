#!/bin/env bash
curl -X 'POST' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/users/register' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{"firstName":"Michael","lastName":"Scott","password":"","email":"123","universityId":"","id":""}' \
  | jq

echo ""
