pipeline {
    agent any
    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore'
        }
        }
        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release --no-restore '
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying...'
            }
        }
    }
}
