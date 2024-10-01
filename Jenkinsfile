pipeline {
    agent any
    stages {
        stage('restore') {
            agent{
                docker { image 'mcr.microsoft.com/dotnet/sdk:7.0'}
            }
            steps {
                sh '''dotnet restore'''
                
                
            }
        }
        stage('restore') {
            steps {
                sh '''dotnet restore'''
                
                
            }
        }
        stage('build') {
            steps {
                sh '''dotnet build --configuration Release --no-restore'''
                
                
            }
        }
    }
}
