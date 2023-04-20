#!/bin/env bash
curl -X 'POST' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/users/register' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{"firstName":"Michael","lastName":"Scott","password":"","email":"123","universityId":"","id":"0a1f90d4-bd46-4c4f-b41f-4c6d4fc02dd9", "university": {"id":"enst", "name":"sst", "address":"description":"strarst", "numberOfStudents":1} }' \
  | jq

echo ""
