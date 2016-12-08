CSHARP=mcs
CSFLAGS=-target:exe -nologo
RM=rm
LATEX=pdflatex
EXTRA_FILES=IWidget.cs IGrommit.cs IPlumbus.cs ZeroGrommit.cs DatabaseGrommit.cs supporting_types.cs

EXAMPLES=main1 main2a main2b main2c
CS_EXAMPLES=$(patsubst %,%.exe,$(EXAMPLES))

all: code docs

code: $(CS_EXAMPLES)

docs: downcasting.pdf

clean:
	-$(RM) *.pdf
	-$(RM) *.aux
	-$(RM) *.out
	-$(RM) *.log
	-$(RM) *.exe

spotless: clean
	-$(RM) *~

main1.exe: main1.cs Widget1.cs $(EXTRA_FILES)
	$(CSHARP) $(CSFLAGS) -out:$@ $+

main2a.exe: main2.cs Widget2a.cs $(EXTRA_FILES)
	$(CSHARP) $(CSFLAGS) -out:$@ $+

main2b.exe: main2.cs Widget2b.cs $(EXTRA_FILES)
	$(CSHARP) $(CSFLAGS) -out:$@ $+

main2c.exe: main2.cs Widget2c.cs $(EXTRA_FILES)
	$(CSHARP) $(CSFLAGS) -out:$@ $+

%.pdf: %.latex *.cs
	$(LATEX) $<
