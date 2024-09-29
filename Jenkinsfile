pipeline {
    agent  {
    docker {
      image 'jenkins/agent:latest'
    }
  }
    stages {
        stage('Restore') {
            steps {
                parallel(
                    a: {
                        echo "Restoring"
                    },
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
