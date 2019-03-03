pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat(script: 'dotnet build aspnetcore/weatherapp/WeatherApi.sln', returnStatus: true, returnStdout: true)
      }
    }
  }
}