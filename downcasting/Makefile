LATEX=pdflatex

all: downcasting.pdf

clean:
	-rm *.pdf
	-rm *.aux
	-rm *.out
	-rm *.log

spotless: clean
	-rm *~

%.pdf: %.latex *.cs
	$(LATEX) $<
