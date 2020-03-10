# Aplicação demo para Azure Application Configuration

![.NET Core](https://github.com/carlosforti/app-config-demo/workflows/.NET%20Core/badge.svg?branch=master)

## Como executar a demo

 1. Criar o recurso no portal do Azure, e copiar a Connection String
 2. Criar as seguintes configurações, com os valores abaixo:
    1. TestApp:Settings:BackgroundColor, white
    2. TestApp:Settings:FontColor, black
    3. TestApp:Settings:FontSize, 24
    4. TestApp:Settings:Message, "Azure Application Configuration"
 3. Executar o seguinte comando

    ```console
    dotnet user-secrets set ConnectionStrings:AppConfig <CONNECTION STRING>
    ```

 4. Execute a aplicação
 5. Para testar, troque os valores das configurações, aguarde 5 segundos e faça um refresh da tela
