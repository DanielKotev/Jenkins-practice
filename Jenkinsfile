pipeline {
    agent any
    tools {
        // Use the .NET SDK tool you configured earlier in Global Tool Configuration
        dotnetsdk 'dotnetsdk'  // Use the name you defined in Jenkins' Global Tool Configuration
    }
    stages {
        stage('Test') {
            steps {
                sh '''dotnet --version'''
                
                
            }
        }
    }
}
