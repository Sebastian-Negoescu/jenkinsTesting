pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'dotnet restore'
                sh 'dotnet build --configuration Debug --output consoleapp'
                sh 'dotnet run consoleapp/jenkins.dll'
            }
        }
    }
}