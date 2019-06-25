#Programming I

####################################
#            Mission 3.2           #
#           Caesar Cipher          #
####################################

#Background
#==========
#The encryption of a plaintext by Caesar Cipher is:
#En(Mi) = (Mi + n) mod 26 

#Write a Python program that prompts user to enter a plaintext
#and displays the encrypted result using Caesar Cipher.

#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.
#2) You MUST (at least) use the following variables:
#   - plaintext
#   - ciphertext

#START CODING FROM HERE
#======================



#Perform Encryption of given plaintext
def caesarEncrypt(plaintext, key):
    #Code to do the conversion
    ciphertext = ""
    for i in range(len(plaintext)):
      char = plaintext[i]
      # Encrypt uppercase characters in plain text
      
      if (char.isupper()):
         ciphertext += chr((ord(char) + key-65) % 26 + 65)
      # Encrypt lowercase characters in plain text
      else:
         ciphertext += chr((ord(char) + key - 97) % 26 + 97)

    print(ciphertext) #Modify to display the encrypted result
    return ciphertext #Do not remove this line

    
#Do not remove the next line
#caesarEncrypt(plaintext,key)

caesarEncrypt('HELLOWORLDTHESECRETISOUT',5)