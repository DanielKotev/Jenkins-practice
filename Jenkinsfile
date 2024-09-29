pipeline {
    agent any
    stages {
        stage('Restore') {
            steps {
                parallel(
                    a: {
                        echo "Restoring"
                    }
                    b: {
                        sh 'dotnet restore'
                    }
                )
                
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
