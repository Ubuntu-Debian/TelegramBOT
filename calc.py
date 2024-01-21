def flo(input_string1,input_string2):
    def convert_to_fraction(input_string):
        parts = input_string.split("/")
        if len(parts) == 2:
            try:
                numerator = int(parts[0])
                denominator = int(parts[1])
                return numerator, denominator
            except ValueError:
                return None
        elif len(parts) == 1:
            try:
                numerator = int(parts[0])
                denominator = 1
                return numerator, denominator
            except ValueError:
                return None
        else:
            return None

    ls = [];
    result1 = convert_to_fraction(input_string1.replace(".","/"))
    result2 = convert_to_fraction(input_string2.replace(".", "/"))
    if result1 is not None:
        if result2 is not None:
            numerator1, denominator1 = result1
            numerator2, denominator2 = result2
            fl1 = float(input_string1.replace("/","."))
            fl2 = float(input_string2.replace("/", "."))

            fp = "{:.1f}".format(fl1 + fl2)
            fm = "{:.1f}".format(fl1 - fl2)
            fd =  "{:.1f}".format(fl1 / fl2)
            fu =  "{:.1f}".format(fl1 * fl2)
            ls.append(f"{input_string1} + {input_string2} = {fp}")
            ls.append(f"{input_string1} - {input_string2} = {fm}")
            ls.append(f"{input_string1} / {input_string2} = {fd}")
            ls.append(f"{input_string1} * {input_string2} = {fu}")

        else:
            ls.append("Не получилось , возможно знак не правильный")
    else:
        ls.append("Не получилось , возможно знак не правильный")
    return ls
#ls = flo("5.2","2.7")
#for row in ls:
    #print(row)