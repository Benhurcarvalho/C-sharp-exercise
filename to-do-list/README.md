# To-Do List em C#

Este é um projeto simples de To-Do List em C#. 
Ele permite que você gerencie tarefas pendentes de forma fácil e eficiente.

## Pré-requisitos

Antes de executar este projeto, você deve ter o .NET SDK instalado no seu sistema. 

Você pode fazer o download em [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

###

Ou pode instalar pelo terminal seguindo as intrunções abaixo:

### 1. Verifique se o .NET SDK não está instalado

dotnet --version

Se você não receber uma versão como resultado, significa que o .NET SDK não está instalado e você pode continuar com os próximos passos.

### 2. Baixe o .NET SDK

## Linux

### Adicione a chave de assinatura Microsoft
wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

### Instale o .NET SDK
sudo apt-get update
sudo apt-get install -y dotnet-sdk-6.0

## macOS


### Baixe o instalador do .NET SDK para macOS
wget https://download.visualstudio.microsoft.com/download/pr/26a26de0-8167-4f67-ba27-acab5f451888/5417dd5a88e7b149dcb33e49de1db2c6/dotnet-sdk-6.0.100-preview.7.21379.14-osx-x64.pkg -O dotnet-sdk.pkg

### Instale o .NET SDK
sudo installer -pkg dotnet-sdk.pkg -target /

## Windows

### Baixe e execute o instalador do .NET SDK para Windows a partir do [site oficial](https://dotnet.microsoft.com/pt-br/download).

### 3. Verifique a instalação
Após a instalação, verifique novamente se o .NET SDK foi instalado corretamente executando o seguinte comando no terminal:

dotnet --version

Agora, você deverá ver a aplicação To-Do List em execução no terminal.

## Uso

A aplicação To-Do List é interativa e você pode seguir as instruções no terminal para adicionar, ver tarefas e remover tarefas.

## Contribuição

Esse é o meu primieor projeto em C#, mas se você deseja contribuir para este projeto, fique à vontade para criar um fork e enviar pull requests com melhorias e não esqueça de deixar um comentário sobre suas add e melhorias.