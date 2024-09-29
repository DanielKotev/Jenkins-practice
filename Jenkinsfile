pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:7.0'
        }
    }
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
