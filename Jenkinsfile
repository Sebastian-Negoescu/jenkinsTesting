pipeline {
    agent { docker { image 'mcr.microsoft.com/dotnet/core/samples:dotnetapp'} }
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