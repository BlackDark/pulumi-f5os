# pulumi-f5os

Pulumi provider bridge for F5OS resources.

## Verify

Use the existing generated build, SDK, lint, and acceptance-test workflows for provider changes. Keep dependency updates grouped through the shared default and Go Renovate presets.

## Generated files

Provider SDKs, `Makefile` targets, and CI workflows are generated through the Pulumi provider bridge; do not hand-edit generated files or apply the generic CI preset directly. Regenerate through the established provider process.

## Map

- `provider/`: provider implementation and tests.
- `sdk/`: generated SDKs; do not hand-edit.
- `examples/`: example programs.
- `.github/workflows/`: generated CI and release automation.

## Git

- Conventional Commits, one topic per PR.
- Squash unless commits need separate review.
- Force-push only with `--force-with-lease` on own branches.

## Boundaries

- Do not create provider tags, publish SDKs, or call live F5OS APIs from a local session.
