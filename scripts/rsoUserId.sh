#!/usr/bin/env bash
curl -X 'GET' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/rsos/0298f118-c7c1-444a-9a81-b50253acf97a' \
  -H 'accept: text/plain' \
  | jq
