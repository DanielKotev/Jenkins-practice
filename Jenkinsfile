pipeline {
    agent any
    tools {
        // Use the .NET SDK tool you configured earlier in Global Tool Configuration
        dotnet 'dotnetsdk'  // Use the name you defined in Jenkins' Global Tool Configuration
    }
    stages {
        stage('Test') {
            steps {
                sh 'dotnet --version'
            }
        }
    }
}
