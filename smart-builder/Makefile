CSHARP=mcs
CSFLAGS=-target:library -nologo
RM=rm
EXTRA_FILES=supporting_types.cs

EXAMPLES=ex1 ex2 ex3 ex4 ex5
CS_EXAMPLES=$(patsubst %,%.dll,$(EXAMPLES))
IMG_EXAMPLES=$(patsubst %,%.png,$(EXAMPLES))

all: code images

code: $(CS_EXAMPLES)

images: $(IMG_EXAMPLES)

clean:
	-$(RM) $(CS_EXAMPLES)

spotless: clean
	-$(RM) $(IMG_EXAMPLES)

%.dll: %.cs $(EXTRA_FILES)
	$(CSHARP) $(CSFLAGS) -out:$@ $+

%.png: %.dot
	dot -Tpng $< > $@

