/** @type {import('next').NextConfig} */
const nextConfig = {
  reactStrictMode: true,
}

if (process.env.NODE_ENV === 'development') {
  require('dotenv').config()
}

module.exports = {
  nextConfig,
  env: {
    API_URL: process.env.API_URL,
  },
  images: {
    domains: ['live.staticflickr.com',
      's3.console.aws.amazon.com',
      'dnd-image-hosting.s3.amazonaws.com'],
  },
}

