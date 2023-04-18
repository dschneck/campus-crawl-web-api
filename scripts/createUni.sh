#!/bin/env bash
curl -X 'POST' \
  'https://localhost:7079/universities' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "id": "string",
  "name": "string",
  "address": "string",
  "description": "string",
  "numberOfStudents": 0
}'
