curl -X 'POST' \
  'http://localhost:5052/api/Hello/Upload1' \
  -H 'accept: */*' \
  -H 'Content-Type: multipart/form-data' \
  -F 'File=@README.md;type=text/markdown' \
  -F 'SubInfos={ "A": "string", "B": "string" }' \
  -F 'SubInfos={ "A": "string", "B": "string" }'