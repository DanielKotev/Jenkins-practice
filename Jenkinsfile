pipeline {
    agent any
    stages {
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
