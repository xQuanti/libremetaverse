Build docker image:
docker build -t simplebot .

run:

docker run -e FIRST_NAME=your_first_name -e LAST_NAME=your_last_name -e PASSWORD=your_password simplebot