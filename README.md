
<!-- PROJECT SHIELDS -->
<!--

*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<p align="center">
 <img width="100px" src="https://res.cloudinary.com/anhhackta/image/upload/v1594908242/logo_ccswme.svg" align="center" alt="GitHub Readme Stats" />
 <h2 align="center">GitHub Readme Stats</h2>
 <p align="center">Get dynamically generated GitHub stats on your READMEs!</p>
</p>
 

  <p align="center">
    <a href="https://github.com/anuraghazra/github-readme-stats/issues/new?assignees=&labels=bug&projects=&template=bug_report.yml">View Demo</a>
    ·
    <a href="https://github.com/anuraghazra/github-readme-stats/discussions/1770">FAQ</a>
    ·
    <a href="https://github.com/anuraghazra/github-readme-stats/discussions/new?category=q-a">Ask Question</a>
  </p>
  

<p align="center">Please note that documentation translations may be outdated; try to use English documentation if possible.</p>

<p align="center">Love the project? Please consider <a href="https://www.paypal.me/anuraghazra">donating</a> to help it improve!</p>

</a>



# Important Notices <!-- omit in toc -->

<img alt="Uptime Badge" src="https://img.shields.io/endpoint?url=https%3A%2F%2Fgithub-readme-stats-git-monitoring-github-readme-stats-team.vercel.app%2Fapi%2Fstatus%2Fup%3Ftype%3Dshields">

> [!IMPORTANT]\
> We're a small team, and to prioritize, we rely on upvotes :+1:. We use the Top Issues dashboard for tracking community demand (see [#1935](https://github.com/anuraghazra/github-readme-stats/issues/1935)). Do not hesitate to upvote the issues and pull requests you are interested in. We will work on the most upvoted first.

# GitHub Stats Card

> [!WARNING]\
> By default, the stats card only shows statistics like stars, commits, and pull requests from public repositories. To show private statistics on the stats card, you should [deploy your own instance](#deploy-on-your-own) using your own GitHub API token.

> [!NOTE]\
> Available ranks are S (top 1%), A+ (12.5%), A (25%), A- (37.5%), B+ (50%), B (62.5%), B- (75%), C+ (87.5%) and C (everyone). This ranking scheme is based on the [Japanese academic grading](https://wikipedia.org/wiki/Academic_grading_in_Japan) system. The global percentile is calculated as a weighted sum of percentiles for each statistic (number of commits, pull requests, reviews, issues, stars, and followers), based on the cumulative distribution function of the [exponential](https://wikipedia.org/wiki/exponential_distribution) and the [log-normal](https://wikipedia.org/wiki/Log-normal_distribution) distributions. The implementation can be investigated at [src/calculateRank.js](https://github.com/anuraghazra/github-readme-stats/blob/master/src/calculateRank.js). The circle around the rank shows 100 minus the global percentile.


#### Responsive Card Theme

[![Anurag's GitHub stats-Dark](https://github-readme-stats.vercel.app/api?username=anhhackta\&show_icons=true\&theme=merko#gh-dark-mode-only)](https://github.com/anhhackta/github-readme-stats#responsive-card-theme#gh-dark-mode-only)
[![Anurag's GitHub stats-Light](https://github-readme-stats.vercel.app/api?username=anhhackta\&show_icons=true\&theme=default#gh-light-mode-only)](https://github.com/anhhackta/github-readme-stats#responsive-card-theme#gh-light-mode-only)

Since GitHub will re-upload the cards and serve them from their [CDN](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/about-anonymized-urls), we can not infer the browser/GitHub theme on the server side. There are, however, four methods you can use to create dynamics themes on the client side.

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/anhhackta/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/anhhackta/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/anhhackta/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/anhhackta/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/anhhackta/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/anhhackta/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/anhhackta/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/anhhackta/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/anhhackta/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/anhhackta/Best-README-Template/blob/master/LICENSE.txt

