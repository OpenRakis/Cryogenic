# GitHub Pages Setup Instructions

This repository is configured to deploy documentation to GitHub Pages automatically using GitHub Actions.

## Prerequisites

GitHub Pages must be manually enabled in the repository settings before the first deployment.

## Setup Steps

1. Navigate to your repository's **Settings** tab
2. In the left sidebar, click on **Pages**
3. Under **Source**, select **GitHub Actions**
4. Save the settings

That's it! Once GitHub Pages is enabled, any push to the `main` branch that modifies files in the `docs/` directory will automatically trigger a deployment.

## Troubleshooting

### Error: "Resource not accessible by integration"

This error occurs when trying to automatically create a GitHub Pages site using the workflow. The solution is to manually enable GitHub Pages in the repository settings as described above.

### Pages Not Updating

If your changes aren't appearing on the GitHub Pages site:

1. Check the **Actions** tab to ensure the workflow ran successfully
2. Verify that GitHub Pages is enabled in repository settings
3. Wait a few minutes for changes to propagate
4. Clear your browser cache and try again

## Workflow Details

The deployment workflow (`.github/workflows/deploy-pages.yml`) is triggered by:
- Pushes to `main` branch that modify `docs/**` files
- Changes to the workflow file itself
- Manual workflow dispatch

For more information about GitHub Pages, see the [official documentation](https://docs.github.com/en/pages).
