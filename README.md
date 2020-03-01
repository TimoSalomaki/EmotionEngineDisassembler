# Emotion Engine Disassembler
![Disassembler screenshot](https://raw.githubusercontent.com/HankiDesign/EmotionEngineDisassembler/master/Screenshots/EmotionEngineDisassembler01.PNG)

Work-in-progress disassembler capable of disassembling machine code of PlayStation 2's Emotion Engine CPU (C790), built with C#.

## TODO

### CPU
- [X] Support the default instruction set
- [ ] Support the extended C790-specific instruction set 
- [ ] Assembler

### UI
- [X] AvalonEdit integration
- [ ] Hierarchical code view (custom-drawn SkiaSharp control?)
- [ ] Jump and branch arrows
- [ ] Go to address functionality
- [ ] Hex line numbers


### General
- [ ] Optimizations (there's way too many conversions, allocations etc. going on right now but that's on purpose to get everything up and running before optimizing)
