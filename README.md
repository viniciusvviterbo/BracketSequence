# Bracket Sequence Checker

Determines if the order of a given string of brackets is valid. A bracket is considered to be any of the following ASCII characters:

| Hex Code | Glyph |
|:--------------:|:-----------:|
| 0x28 | ( |
| 0x29 | ) |
| 0x5B | [ |
| 0x5D | ] |
| 0x7B | { |
| 0x7D | } |

A sequence will be deemed valid if:
1. It contains no unmatched brackets;
2. The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.

## Setting the project up

## Usage

### CLI

Clone this repository and execute:

```bash
dotnet restore
dotnet run
```

### Docker

Run the existing image by executing:

```bash
docker pull viniciusvviterbo/bracketsequence:latest
docker run -it --rm viniciusvviterbo/bracketsequence:latest
```
or build your own image by cloning this repository and executing:

```bash
dotnet restore
dotnet publish -c Release

docket build -t viniciusvviterbo/bracketsequence .
docker run -it --rm viniciusvviterbo/bracketsequence
```

**[GNU AGPL v3.0](https://www.gnu.org/licenses/agpl-3.0.html)**
