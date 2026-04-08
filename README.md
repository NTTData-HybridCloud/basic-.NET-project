# basic-.NET-project

Proyecto .NET básico pensado como punto de partida para practicar una CI sencilla con GitHub Actions.

## Estructura

```text
basic-.NET-project/
	BasicDotNetProject.sln
	README.md
	src/
		App.csproj
		Program.cs
	tests/
		AppTests.csproj
		AppTests.cs
```

## Requisitos

- .NET 8.0+

## Ejecutar en local

Restaurar dependencias:

```bash
dotnet restore
```

Ejecutar tests:

```bash
dotnet test
```

Ejecutar la aplicación:

```bash
dotnet run --project src/App.csproj
```

Salida esperada:

```text
Hello world!
```

## Idea de CI basica

Para un workflow inicial de GitHub Actions, puedes empezar con estos pasos:

1. Checkout del repositorio.
2. Setup de .NET 8.
3. `dotnet restore`.
4. `dotnet build`.
5. `dotnet test`.
6. (Opcional) Empaquetar y publicar artefacto en GitHub Packages (GHCR).
