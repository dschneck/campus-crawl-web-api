#! /usr/bin/env bash
curl  -X 'GET' \
-H "Authorization: Bearer $(gcloud auth print-identity-token)" \
-H 'accept: text/plain' \
https://campus-crawl-web-api-server-32wswsezka-uc.a.run.app/rsos
echo ""
