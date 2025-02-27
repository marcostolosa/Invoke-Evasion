# Invoke-Evasion

This repository contains various datasets, Jupyter notebooks, and machine learning models that accompany the "Learning Machine Learning" series of blog posts:

- [Learning Machine Learning Part 1: Introduction and Revoke-Obfuscation](https://posts.specterops.io/learning-machine-learning-part-1-introduction-and-revoke-obfuscation-c73033184f0)
- Learning Machine Learning Part 2: Attacking White Box Models
- Learning Machine Learning Part 3: Attacking Black Box Models

## Structure

./notebooks/
- **Feature Selection.ipynb** - code for performing the various types of feature selection
- **LogisticRegression.ipynb** - training a tuned Logistic Regression model on the augmented obfuscated PowerShell dataset
- **TreeModels.ipynb** - training various tree ensemble models on the augmented obfuscated PowerShell dataset
- **NeuralNetworks.ipynb** - training various Neural Network models on the augmented obfuscated PowerShell dataset

./models/
- **tuned_ridge.bin** - Pickled tuned L2 (Ridge) regularized Logistic Regression model pipeline trained on the augmented obfuscated PowerShell dataset
- **tuned_lgbm.bin** - Pickled tuned LightGBM classifier model trained on the augmented obfuscated PowerShell dataset
- **./neural_network/** - Saved model weights for a 4-layer 192 neuron Neural Network with a dropout of .5

./datasets/
- **PowerShellCorpus.ast.csv.7z** - compressed csv of AST features extracted from an augmented PowerShell corpus dataset of 14702 samples

./PS-AST/
- C# project that integrates the [checks from Revoke-Obfuscation](https://github.com/danielbohannon/Revoke-Obfuscation/tree/master/Checks) (by Daniel Bohannon & Lee Holmes, Apache License 2.0) for AST file generation. Also contains **SplitScriptFunctions** that outputs every function in a script to a separate file, used for data augmentation.
