# Conversor MKV para MP4

Este é um utilitário simples em **C#** para converter arquivos de vídeo do formato MKV para MP4 de forma rápida e eficiente. Ele utiliza o [FFmpeg](https://ffmpeg.org/) para realizar a conversão, garantindo alta compatibilidade e qualidade nos arquivos gerados.

## Funcionalidades

- Conversão de arquivos MKV para MP4
- Preserva qualidade de áudio e vídeo
- Suporte a múltiplos arquivos
- Interface de linha de comando simples
- Processamento rápido e eficiente

## Pré-requisitos

- [.NET 6.0+](https://dotnet.microsoft.com/) instalado
- [FFmpeg](https://ffmpeg.org/) instalado e disponível no PATH do sistema

## Instalação

Clone este repositório:

```bash
git clone https://github.com/seu-usuario/conversor-mkv-mp4.git
cd conversor-mkv-mp4
```

Restaure as dependências e compile o projeto:

```bash
dotnet restore
dotnet build
```

## Uso

### Conversão de um único arquivo

```bash
dotnet run -- video.mkv
```

O arquivo `video.mp4` será gerado no mesmo diretório.

## Exemplo de comando `ffmpeg` utilizado

```bash
ffmpeg -i input.mkv -c copy output.mp4
```
> Este comando converte rapidamente sem recodificar áudio ou vídeo. Para arquivos incompatíveis, utilize:
```bash
ffmpeg -i input.mkv -c:v libx264 -c:a aac output.mp4
```

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

## Contribuição

Pull requests são bem-vindos! Para grandes mudanças, abra uma issue antes para discutir o que você gostaria de modificar.

## Suporte

Em caso de dúvidas ou problemas, abra uma issue neste repositório.

---
Feito com ❤️ por Rafael Mendes
