#!/bin/env bash
curl -X 'POST' \
  'https://localhost:7079/users/login' \
  -H 'accept: text/plain' \
  -H 'Content-Type: application/json' \
  -d '{
  "email": "david.schneckster@hotmail.com",
  "password": "password"
}'
