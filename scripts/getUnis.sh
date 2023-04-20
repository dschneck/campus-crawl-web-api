#!/bin/env bash
curl -X 'GET' \
  'https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/universities' \
| jq

echo ""
