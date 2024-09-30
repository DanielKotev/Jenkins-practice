pipeline {
    agent {
        docker { image 'dotnet-sdk-7' }
    }
    stages {
        stage('Test') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}
