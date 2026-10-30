# NEA Music AI

An A-level Computer Science Non-Exam Assessment project exploring the use of artificial intelligence to generate video-game music.

## Contents

- [Overview](#overview)
- [Objectives](#objectives)
- [Features](#features)
- [Technology](#technology)
- [Project Structure](#project-structure)
- [Training](#training)
- [Testing](#testing)
- [Limitations and Future Improvements](#limitations-and-future-improvements)
- [Author](#author)

## Overview

NEA Music AI is a coursework project investigating how artificial intelligence can be applied to music generation. The system processes musical data and uses a neural network to generate AI-assisted musical output.

The project documents the software development process, including requirements analysis, system design, implementation, training, testing, evaluation, and reflection.

## Objectives

- Explore the use of artificial intelligence in a music-focused application.
- Design and implement a usable software solution.
- Process musical input in a structured and repeatable way.
- Train a neural network to predict the next note in a sequence.
- Evaluate the quality and usefulness of the generated output.
- Record design decisions and development progress as part of the NEA coursework.

## Features

- Video-game-music-focused AI functionality.
- Musical data processing and preparation.
- Neural-network-based next-note prediction.
- Input processing and validation.
- AI-assisted music generation.
- Testing and evaluation of generated results.

## Technology

- **Languages:** C# for the AI implementation and mathematical calculations; Python for obtaining and editing the training data.
- **Framework:** .NET Framework.
- **Dataset:** Musical data sourced from [VGMusic](https://www.vgmusic.com/).
- **Training method:** Backpropagation and gradient descent.

## Project Structure

Update the descriptions below if the repository structure changes.

```text
NEA-Music-AI/
├── data/              # Music data or sample input files
├── models/            # Saved or trained AI models
├── src/               # Main source code
├── tests/             # Automated or manual test resources
├── requirements.txt   # Python dependencies, if applicable
└── README.md          # Project documentation
```

## Training

The AI is trained using sequences of 17 notes:

- The first 16 notes are provided as input nodes.
- The 17th note is used as the expected output.

Backpropagation is used to calculate the gradients of the network's weights and biases. Gradient descent then adjusts these values iteratively to reduce the error between the predicted note and the expected note.

This process aims to find suitable weights and biases that allow the network to predict the next note in a musical sequence.

## Testing

Testing covers valid, invalid, and edge-case inputs, including:

- Input validation.
- Musical data processing.
- Neural-network training and prediction.
- Generated output format and usability.
- Error handling.
- The quality and consistency of generated music.

## Limitations and Future Improvements

The main limitation was the choice of training data. The dataset contained complete compositions rather than isolated melodies or lead lines. Consequently, the data included sound effects, including explosion sounds, which affected the quality and usefulness of the generated output.

Potential areas for future development include:

- Using a dataset better suited to the project's requirements.
- Training the AI on isolated melodies instead of complete compositions.
- Improving the quality and consistency of generated music.
- Expanding the size and variety of the training and evaluation data.
- Adding more user controls and configuration options.
- Improving runtime performance.
- Adding a graphical user interface.
- Providing clearer visual feedback about how the AI produces its output.
- Comparing different algorithms and model configurations.

## Author

Developed by **Ben Jordan** as part of an A-level Computer Science NEA project.
