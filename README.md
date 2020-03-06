# Emotion Engine Disassembler
![Disassembler screenshot](https://raw.githubusercontent.com/HankiDesign/EmotionEngineDisassembler/master/Screenshots/EmotionEngineDisassembler01.PNG)

Work-in-progress disassembler capable of disassembling machine code of PlayStation 2's Emotion Engine CPU (C790), built with C#. The current version is single threaded and can decode around 300'000 instructions per second on a Dell Latitude E7240 laptop (i7-4600U @ 2.10GHz). There are still important tasks that should be done before this is ready for any real use, for example the register names are not parsed yet and tests are completely missing. It's also very likely that some of the instructions are decoded incorrectly.

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
