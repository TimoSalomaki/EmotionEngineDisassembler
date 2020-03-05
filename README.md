# Emotion Engine Disassembler
![Disassembler screenshot](https://raw.githubusercontent.com/HankiDesign/EmotionEngineDisassembler/master/Screenshots/EmotionEngineDisassembler01.PNG)

Work-in-progress disassembler capable of disassembling machine code of PlayStation 2's Emotion Engine CPU (C790), built with C#. It's currently very slow and doesn't output proper assembly (for example, register names are not shown as they're just binary for now). Also, not much thought has been put into how this solution should be generalized to possibly allow for other instruction sets to be implemented in the future.

All the implementation so far has been done by following the [official documentation](https://wiki.qemu.org/images/2/2a/C790.pdf) of the processor from Toshiba.

## TODO

### CPU
- [X] Support the default instruction set
- [X] Support the extended C790-specific instruction set 
- [X] Support the COP0 system control coprocessor instruction set
- [X] Support the COP1 (FPU) coprocessor instruction set
- [ ] Register name parsing
- [ ] Assembler
- [ ] Pseudo instructions (nop is already one)

### UI
- [X] AvalonEdit integration
- [X] Syntax highlighting for MIPS instructions
- [ ] Hierarchical code view (custom-drawn SkiaSharp control?)
- [ ] Jump and branch arrows
- [ ] Go to address functionality
- [ ] Hex line numbers
- [ ] Docking


### General
- [ ] Optimizations (there's way too many conversions, allocations etc. going on right now but that's on purpose to get everything up and running before optimizing)
- [ ] Unit tests
- [ ] Open/save file
- [ ] Multithreading
