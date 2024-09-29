pipeline {
    agent {
        docker { image 'dotnet-sdk-7' }
    }
    stages {
        stage("Install .net"){
            steps{
                sh 'dotnet --version'
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
