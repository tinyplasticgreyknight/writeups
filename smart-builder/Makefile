CSHARP=mcs
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

%.dll: %.cs
	$(CSHARP) -out:$@ -target:library $(EXTRA_FILES) $<

%.png: %.dot
	dot -Tpng $< > $@

