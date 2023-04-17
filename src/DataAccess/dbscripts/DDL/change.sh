for file in ./*
do
    sed 's/STRING/STRING/g; s/STRING(MAX)/STRING(MAX)/g; s/INT64/INT6464/g' -i $file
done
