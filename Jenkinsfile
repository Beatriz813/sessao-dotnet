pipeline {
    agent any
    stages {
        stage('Gera Imagem') {
            steps {
                sh 'ls'
                sh 'docker build -t sessao-api .'
            }
        }
        stage('Roda conteiner') {
            steps {
                sh 'ls'
                sh 'docker run -d -p 4000:80 -p 3000:433 -e ASPNETCORE_ENVIRONMENT=Development sessao-api'
            }
        }
    }
}