# Use the official image as a parent image.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory.
WORKDIR /app

# Copy everything except what's listed in .dockerignore.
COPY . .

# Set environment variables.
ENV FIRST_NAME=your_first_name
ENV LAST_NAME=your_last_name
ENV PASSWORD=your_password
ENV MAC=your_mac_address
ENV ID0=your_id0
ENV CHANNEL=your_channel
ENV VERSION=your_version


# Build the app.
WORKDIR /app/SimpleBot/

# Run the app.
CMD ["dotnet", "run"]