pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build aspnetcore/weatherapp/WeatherApi.sln'
      }
    }
  }
}