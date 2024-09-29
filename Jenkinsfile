pipeline {
    agent any
    stages {
        stage("Install .net"){
            steps{
                docker {
                image 'dotnet-sdk-7'
                }
            }
        }
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
