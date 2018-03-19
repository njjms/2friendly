env 'TEST_URL' {
    fallback: 'https://www.instagram.com'
} -> $url

env 'username' -> $username
env 'password' -> $password
