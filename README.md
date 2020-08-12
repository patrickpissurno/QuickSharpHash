# QuickSharpHash
CLI tool for quickly hashing files with SHA256 and base-64 encoding.

**Requires a modern version of the .NET Framework runtime.**

### Usage examples:
```hash.exe somefile1.wav```

```hash.exe somefile1.exe somefile2.dll somefile3.txt somefile4.mp4 [...]```

You can also drag and drop files into the executable to quickly hash them.

![screenshot](https://i.imgur.com/sLftmZb.png)

It will then output hashes to `stdout`.

### Motivation
I needed a quick bloat-free tool to (batch) generate those hashes as quickly as possible and didn't want to spend much time looking for a pre-existing one.

### Downloads
I'm providing a precompiled version for download in the [Releases](https://github.com/patrickpissurno/QuickSharpHash/releases/latest) tab.

### License
MIT
