pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat(script: 'dotnet build aspnetcore/weatherapp', returnStatus: true, returnStdout: true)
      }
    }
  }
}