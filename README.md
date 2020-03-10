# Aplicação demo para Azure Application Configuration

![.NET Core](https://github.com/carlosforti/app-config-demo/workflows/.NET%20Core/badge.svg?branch=master)

## Como executar a demo

 1. Criar o recurso no portal do Azure, e copiar a Connection String
 2. Criar as seguintes configurações, com os valores abaixo:
    * TestApp:Settings:BackgroundColor: white
    * TestApp:Settings:FontColor: black
    * TestApp:Settings:FontSize: 24
    * TestApp:Settings:Message: "Azure Application Configuration"
 3. Crie uma variável de ambiente chamada APP_CONFIG, e configure com a string de conexão
 4. Execute a aplicação
 5. Para testar, troque os valores das configurações, aguarde 5 segundos e faça um refresh da tela
